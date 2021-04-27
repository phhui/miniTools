using System;

namespace QModule.template
{
    class Egret
    {
        public static String cmd = @"
class Pq_TemplateCmd{
    static SHOW_WINDOW:string='Pq_Template_show_window';
    static CLOSE_WINDOW:string='Pq_Template_close_window';
    static INIT_DATA:string='Pq_Template_init_data';
}";
        public static String controll = @"
class Pq_TemplateController extends BaseCtr{
    static NAME:string='Pq_TemplateController';
    private pxy:Pq_TemplateProxy;
    private bgDict:Object;
    private starType:number=0;
    constructor(){
        super();
        //this.btnNameList.push('btnName');
        //this.funcList.push(this.btnClick);
        this.target = this;
    }
    public execute(param:Object=null,type:string=null){
        switch(type){
            case Pq_TemplateCmd.SHOW_WINDOW:
                this.showWindow();
            break;
            case Pq_TemplateCmd.CLOSE_WINDOW:
                this.closeWindow();
            break;
        }
    }
    private initUi(){
        this.ui=new Pq_TemplateUi();
        this.pxy=this.getProxy(Pq_TemplateProxy.NAME);
        this.inited=true;
    }
    private showWindow(){
        if(!this.inited)this.initUi();
        this.call(SysCmd.ADD_TO_STAGE,this.ui);
    }
    private closeWindow(){
	    this.call(SysCmd.REMOVE_FROM_STAGE,this.ui);
    }
    private btnClick(type:string,target:any){
        switch(type){
            case 'btnName':
                //console.log('btnClick');
            break;
        }
    }
}";
        public static String mgr = @"
class Pq_TemplateMgr extends BaseMgr{
    constructor(){
        super();
    }
    protected start():void{
	    if(this.isStart)return;
		this.regProxy(Pq_TemplateProxy.NAME,new Pq_TemplateProxy());
		this.regController(Pq_TemplateController.NAME,new Pq_TemplateController());
		this.isStart=true;
	}
	protected get EventList():Array<any>{
		return [Pq_TemplateCmd.SHOW_WINDOW,
					Pq_TemplateCmd.CLOSE_WINDOW,
					Pq_TemplateCmd.INIT_DATA];
	}
	protected execute(type:string, param:Object=null):void{
		switch(type){
			case Pq_TemplateCmd.INIT_DATA:
				this.proxy(Pq_TemplateProxy.NAME,param,type);
			break;
			default:
				this.control(Pq_TemplateController.NAME,param,type);
			break;
		}
	}
}";
        public static String proxy = @"
class Pq_TemplateProxy extends BaseProxy{
    static NAME:string='Pq_TemplateProxy';
	public execute(param:any= null, type:string= null):void{
		switch(type){
			case Pq_TemplateCmd.INIT_DATA:
				this.initData();
				break;
		}
    }
    private initData()
    {

    }
}";
        public static String ui = @"
class Pq_TemplateUi extends BaseUI{
    constructor(){
        super();
    }
    protected addToStage(e:egret.Event){
        
    }
}";
    }
}
