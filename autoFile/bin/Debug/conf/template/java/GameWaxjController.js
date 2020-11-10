chaos.angular.controller('GameWaxjController', ['$scope',  '$http', '$interval','$timeout','$rootScope','$compile', function($scope,  $http, $interval,$timeout, $rootScope,$compile){
	var $this = $("div[data-page='game-waxj']");
	if(!$rootScope.api_login){
		chaos.fw7.alert("您的游戏已经掉线了,请重新登录!",MSG.T_00,function(){chaos.fw7.curView.router.back()});
		return;
	}
	if(!$rootScope.GAME_ID){
		chaos.fw7.alert(MSG.E_07,MSG.T_00,function(){chaos.fw7.curView.router.back()});
		return;
	}
	
	$this.unbind("click").click(function(e){
        var targeta = $(e.target);
        	//关闭更多游戏
        	$this.find(".game-menu:visible").hide();
        	$this.find(".marskdiv").hide();
       // window.event? window.event.cancelBubble = true : e.stopPropagation();
    })
    $this.find(".more-game-menu").click(function(event){
    	$this.find(".game-menu:hidden").show();
    	$this.find(".marskdiv").show();
    	window.event? window.event.cancelBubble = true : e.stopPropagation();
    	
    })
    var page_remove=false;
	var rtrigger = chaos.fw7.onPageBeforeRemove('game-brnn',function(page){
		$interval.cancel($scope.timer);
		$scope.$destroy();
		window.removeEventListener('message',handlerMessage,false);
		//if(egret)egret=null;
		page_remove =true;
		rtrigger.remove();
	})
	var gamebox;
	$scope.isinited = false;
	$scope.game = $rootScope.gameMap[$rootScope.GAME_ID];
	$scope.game.startSeconds=0;
	if(!$scope.game){
		chaos.fw7.alert(MSG.E_07,MSG.T_00,function(){chaos.fw7.curView.router.back()});
		return
	}
	$scope.clear = function(){
		if(getGameBox(true)){
			console.log(2);
			gamebox.contentWindow.cancelChip();
		}
	}
	$scope.qqcg={"da":"大",
			"xiao":"小",
			"dan":"单",
			"shuang":"双",
			"dadan":"大单",
			"xiaodan":"小单",
			"dashuang":"大双",
			"xiaoshuang":"小双",
			"baozi":"豹子",
			"shunzi":"顺子"};
	$scope.qqcgplay = {
			"大单":"QQC001001001",
			"豹子":"QQC001001002",
			"小单":"QQC001001003",
			"大"  :"QQC001001004",
			"小"  :"QQC001001005",
			"单"  :"QQC001001006",
			"双"  :"QQC001001007",
			"大双":"QQC001001008",
			"小双":"QQC001001009",
			"顺子":"QQC001001010"
	}
	$scope.subbet=false;
	$scope.addItem = function(){
		if($scope.subbet)return;
		$scope.subbet=true;
		if(!$scope.game.period && !$scope.game.period.open){
    		chaos.fw7.alert(MSG.T_05,MSG.T_00);
    		$scope.subbet=false;
    		return;
    	}
		if(getGameBox(true)){
			var items = gamebox.contentWindow.getBetData();
			
			if(!items|| !items.length){
				chaos.fw7.alert(MSG.E_09,MSG.T_00);
				return;
			}
			$scope.orders = {
	            issue: $scope.game.period.fullIssue,
	            playId: $scope.game.playId,
	            gameId: $scope.game.id,
	            items: [],
	            betType: 0,
	            totalMoney: 0
		    };
			try{
				$.each(items,function(i,e){
					if(e.length!=2){
						throw new "注单格式不正确"
					}
					var code = $scope.qqcg[e[0]];
					var betmy = parseInt(e[1])
					var play = $scope.qqcgplay[code];
					var odds = $scope.betPlayLabel[play].odds;
					$scope.orders.items.push({
                        project: code,
                        codes: code,
                        odds: odds,
                        methodId: play,
                        money: betmy,
                        methodname: "DIAN",
                        type: "digital",
                        playName: "双面",
                        description: "双面 "+code
                    })
                    $scope.orders.totalMoney += betmy;
				})
				if(!$scope.orders||!$scope.orders.items||!$scope.orders.items.length){
	    			chaos.fw7.alert(MSG.E_09,MSG.T_00);
	    			$scope.subbet=false;
	    			return;
	    		}
				
			}catch(e){
				chaos.fw7.alert(e);
				$scope.subbet=false;
			}
			$http.post(gameUrl+ "/rest/game/lottery/savebet/"+$scope.game.playId+"/"+$scope.game.id, $scope.orders).success(function(data){
				if(data.status){
					sendFrmMsg({"type":"bet",result:data.status});
					$rootScope.updateGameMoney();
					chaos.fw7.alert(MSG.S_07,MSG.T_00,function(){$scope.subbet=false;});
				}else if(data.result.order && data.result.order.orders && data.result.order.orders.length){
					var msg = MSG.W_05.replace("[success]", data.result.order.successNum).replace("[fail]", data.result.order.failNum);
					msg += '<div class="floatarea" style="height:100px;overflow-y:auto">';
					$.each(data.result.order.orders, function (i, n) {
						msg += n + "<br/>";
					});
					msg += '</div>';
					chaos.fw7.confirm(MSG.W_07.replace('[content]',msg), MSG.T_00, function(){
						$scope.clear();$scope.subbet=false;
					},function(){$scope.subbet=false;});
				}else{
					chaos.fw7.alert(data.message,MSG.T_00, function(){$scope.clear();$scope.subbet=false;});
				}
				
			}).error(function(data){
				$scope.subbet=false;
			});
		}else{
			$scope.subbet=false;
		}
	}
	function getGameBox(mual){
		if(!$scope.inited){
			if(mual)chaos.fw7.alert("游戏加载中");
			return null;
		}
		if(typeof gamebox != "undefined"&& typeof gamebox.contentWindow != "undefined")return gamebox;
		if($this.find("#gamebox").size()){
			gamebox = $this.find("#gamebox").get(0);
			return gamebox;
		}
		if(mual)chaos.fw7.alert("游戏加载中..");
		return null;
	}
	function handlerMessage(event){
			if(window== event.source)return;
			var data =event.data;
			try{
				if(data.type=='init'){
					$scope.inited = true;
					if($scope.betPlayLabel){
						sendFrmMsg({type:'odds',odds:$scope.betPlayLabel});
					}else{
						init(true);
					}
					if($scope.top5award && $scope.top5award.length){
						sendFrmMsg({type:'top5award',award:$scope.top5award});
					}
					
				}else if(data.type=='actioncomplete'){
						var obj={type:'top5award',award:$scope.top5award};
						sendFrmMsg(obj);
						$rootScope.updateGameMoney();
						if(!page_remove)
							loadPeriod();
				}
			}catch(e){
				
			}
	}
	function sendFrmMsg(obj){
		if(getGameBox()){
			gamebox.contentWindow.postMessage(obj,'*');
		}
	}
	window.addEventListener('message',handlerMessage,false)
	init();
	loadPeriod();
	loadAward();
	$rootScope.getUserInfo();
	function init(load){
		
		$http.get(gameUrl + "/rest/game/lottery/loadamode/"+$scope.game.id,{params:{play:$scope.game.playId,track:false}}).success(function(data){
			if(data.status){
				$scope.betPlayLabel = data.result.betPlayLabel;
				$scope.odds = data.result.betPlayLabel;
				if(load){
					sendFrmMsg({type:'odds',odds:$scope.betPlayLabel});
				}
				
			}
		});
	}
	function loadPeriod(){
		$http.get(gameUrl + "/rest/game/lottery/loadperiod/"+ $scope.game.id).success(function(data){
			if(data.status){
				handPeriod(data);
			}else
				chaos.fw7.alert(data.message,MSG.T_00,function(){chaos.fw7.curView.router.back()});
		});
	}
	function handPeriod(data){
		if(!data.result.period){
			chaos.fw7.alert(data.message,function(){chaos.fw7.curView.router.back();});
			return;
		}
		$scope.currentTimes = data.result.nowTime;
		if(!data.result.period.open ){
			if (data.result.period.status==0){
				chaos.fw7.alert(MSG.T_06,MSG.T_00);
			}
			if(data.result.period.status==3)
				data.result.period.stateDesc = MSG.D_04;
		}
		
		$scope.game.startSeconds = ($scope.game.closeFlag>-1?data.result.period.startSeconds:data.result.period.awardSeconds) - $scope.currentTimes;
		$scope.game.period = data.result.period;
		//$scope.betContent.issue = data.result.period.fullIssue;
		sendFrmMsg({type:'start'});
		if(!page_remove)
			$scope.timer = $interval(downseconds,1000);
	}
	function downseconds(){
		$scope.game.startSeconds--;
		if($scope.game.startSeconds<=0){
			sendFrmMsg({type:'period',issue:$scope.game.period.fullIssue,downcount:0});
			$interval.cancel($scope.timer);
			$timeout(function(){
				if(!page_remove)
					loadnewaward(1);
			},100);
		}else
			sendFrmMsg({type:'period',issue:$scope.game.period.fullIssue,downcount:$scope.game.startSeconds});
	}
	
	
	$scope.awards=[];
	$scope.awardissue=[];
	$scope.top5award = [];
	$scope.tryTimes = 0;
	function loadnewaward(){
		if($scope.tryTimes>=13){
			if(!page_remove)
				loadPeriod();
			return;
		}
		$scope.tryTimes++;
		$http.get(gameUrl+"/rest/game/lottery/loadaward/"+$scope.game.id,{params:{top:1}}).success(function(data){
			if(!data.status){
				if(!page_remove)
					$timeout(loadnewaward,1000);
			}else{
				for (var i = data.result.award.length; i--;) {
					var e = data.result.award[i];
					if(e.issue!=$scope.game.period.fullIssue){
						if(!page_remove)
							$timeout(loadnewaward,1000);
						return;
					}
					
					$scope.tryTimes=0;
					var aw = getaward(e);
					var obj={type:'award', award: e.result};
					sendFrmMsg(obj);
					if($.inArray(e.issue,$scope.awardissue)<0){
						$scope.top5award.push(aw.total);
						if($scope.top5award.length>5)
							$scope.top5award.shift();
						$scope.awards.splice(0,0,aw);
						$scope.awardissue.push(e.issue);
					}
				}
				
			}
		})
	}
	function loadAward(top){
		$http.get(gameUrl+"/rest/game/lottery/loadaward/"+$scope.game.id,{params:{top:top||20}}).success(function(data){
			if(data.status){
                for (var i = data.result.award.length; i--;) {
                    var e = data.result.award[i];
                    
                    var aw = getaward(e);
                    if($.inArray(e.issue,$scope.awardissue)<0){
                    	$scope.top5award.push(aw.total);
                    	if($scope.top5award.length>5)
                    		$scope.top5award.shift();
                    	$scope.awards.splice(0,0,aw);
                    	$scope.awardissue.push(e.issue);
                    }
                }
                var obj={type:'top5award',award:$scope.top5award};
                sendFrmMsg(obj);
              }
		})
	}
	function getaward(e){
		var  results =  e.result.substring(e.result.length - 3).split('');
		var issue = e.issue;
        if (e.issue.indexOf("-") != -1) issue = e.issue.split("-")[1];
		var aw = {
                issue: issue,
                total: 0,
            };
		$.each(results, function(k, v) {
            aw.total += parseInt(v, 10);
        });
       // results = results.sort((a,b)=>{return a-b;});
        aw.isbig=(aw.total>=14);
        aw.issmall=(aw.total<14);
        aw.issingle=(aw.total%2==1);
        aw.isdouble=(aw.total%2==0);
        aw.isbigdouble=(aw.total>=14 && aw.total % 2 ==0);
        aw.issmalldouble=(aw.total<14 && aw.total % 2 ==0);
        aw.isbigsingle=(aw.total>=14 && aw.total % 2 ==1);
        aw.issmallsingle=(aw.total<14 && aw.total % 2 ==1);
        aw.issort =Math.abs(parseInt(results[0], 10) -parseInt(results[1], 10))==1 && Math.abs(parseInt(results[1], 10)-parseInt(results[2], 10))==1;
        aw.issame = (results[0] == results[1] && results[1] == results[2]);
        return aw;
	}
}])