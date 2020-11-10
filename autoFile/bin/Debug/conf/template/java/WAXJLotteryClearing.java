package com.chaos.gaia.lottery.clearing;

import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

import com.chaos.gaia.lottery.IBetLtNoclearingRecord;
import com.chaos.gaia.lottery.IGameAppellation;

/**
 * 排列三开奖验证
 */
public class WAXJLotteryClearing extends LtClassicLotteryClearing {
	private int [][] niup = new int[4][5];
	private int [][] dianp = new int[4][5];
	private static Map<String,Integer> PAI_ZHIMAP =new HashMap<>();
	static{
		PAI_ZHIMAP.put("A", 1);
		for(int i=2;i<=10;i++)
			PAI_ZHIMAP.put(String.valueOf(i), i);
		//PAI_ZHIMAP.put("J", 11);
		//PAI_ZHIMAP.put("Q", 12);
		//PAI_ZHIMAP.put("K", 13);
	}
	public WAXJLotteryClearing(IGameAppellation game, IBetLtNoclearingRecord record, String result) {
		super(game, record);
		this.gamePlay = "WAXJ";
		this.result = result.split("[,]");
		this.award = result;
		validopenaward();
		
	}
	@Override
	protected void customopenaward() {
		//开奖号码为 1-4 开头(4:黑桃，3：红心，2：梅花，1：方块)+(2-10,JQKA) 1A = 100+1，4A=400+1
		for(int i=0;i<result.length;i++){
			int num = PAI_ZHIMAP.get(result[i].substring(1));
			niup[i/5][i%5] = Math.min(num, 10);
			dianp[i/5][i%5] = Integer.valueOf(result[i].substring(0,1))*100+num;
			Arrays.sort(dianp[i/5]);
		}
		switch (record.getGamePlayId()) {
			case "WAXJ001001001":  // 庄1
			case "WAXJ001001002":  // 庄2
			case "WAXJ001001003":  // 庄3
			case "WAXJ001001004":  // 闲1
			case "WAXJ001001005":  // 闲2
			case "WAXJ001001006": { // 闲3
				valid();
			} // end 顺子
		}

	}
	//0平  1庄赢  2闲赢
	private int countSize(int[] zp,int[] zd,int[] xp,int[] xd){
		if(countNiu(zp)>countNiu(xp))return 1;
		else if(countNiu(zp)<countNiu(xp))return 2;
		else{
			int len=zd.length;
			for(int i=len-1;i>=0;i--){
				if(zd[i]>xd[i])return 1;
				else if(zd[i]<xd[i])return 2;
			}
			return 0;
		}
	}
	//算牛
	private int countNiu(int[] pai){
		int len = pai.length;
		boolean niu = false;
		int niunum = 0;
		NIU: for (int i = 0; i < len - 2; i++)
			for (int j = i + 1; j < len - 1; j++)
				for (int k = j + 1; k < len; k++) {
					int num = pai[i] + pai[j] + pai[k];
					niu = num % 10 == 0;
					if (niu) {
						for(int l=0;l<len;l++)
							niunum+=(pai[l]%10);
						niunum=niunum==0?10:niunum;
						break NIU;
					}
				}
		return niu?niunum:0;//10牛牛 0无牛
	}
	private void valid(){
		if (!record.getBetItem().matches("^(庄|闲)[1-3]$")) {
			msg = ErrorBet;
			return;
		}
		isValid = true;
		switch(record.getBetItem()){
			case "庄1":
				if(countSize(niup[0],dianp[0],niup[1],dianp[1])==1)
					setWin();
				break;
			case "庄2":
				if(countSize(niup[0],dianp[0],niup[2],dianp[2])==1)
					setWin();
				break;
			case "庄3":
				if(countSize(niup[0],dianp[0],niup[3],dianp[3])==1)
					setWin();
				break;
			case "闲1":
				if(countSize(niup[0],dianp[0],niup[1],dianp[1])==2)
					setWin();
				break;
			case "闲2":
				if(countSize(niup[0],dianp[0],niup[2],dianp[2])==2)
					setWin();
				break;
			case "闲3":
				if(countSize(niup[0],dianp[0],niup[3],dianp[3])==2)
					setWin();
				break;
			default:
				
				break;
		}
	}
	
	

}
