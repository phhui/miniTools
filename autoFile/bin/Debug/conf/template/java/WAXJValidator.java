package com.chaos.gaia.lottery.validator;

import java.math.BigDecimal;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

import com.chaos.gaia.lottery.IBetInfo;

public class WAXJValidator extends GameValidator {
	private final static Map<String,String> METHOD_TYPE =new HashMap<>();
	static{
		METHOD_TYPE.put("WAXJ001001001", "ZHUANG1");
		METHOD_TYPE.put("WAXJ001001002", "ZHUANG2");
		METHOD_TYPE.put("WAXJ001001003", "ZHUANG3");
		METHOD_TYPE.put("WAXJ001001004", "XIAN1");
		METHOD_TYPE.put("WAXJ001001005", "XIAN2");
		METHOD_TYPE.put("WAXJ001001006", "XIAN3");
	
		
	}
	public WAXJValidator(IBetInfo item) {
		super(item);
		playType =0;
		methodType = METHOD_TYPE;
	}
	
	public WAXJValidator() {
	}
	
	@Override
	protected boolean validCustom() {
		if(item.getOdds()==null || item.getOdds().compareTo(BigDecimal.ZERO)<0){
			message="未指定赔率";
			return false;
		}
		switch (item.getMethodname()) {
			case "ZHUANG1": {
				return "庄1".equals(item.getCodes());
			}
			case "ZHUANG2": {
				return "庄2".equals(item.getCodes());
			}
			case "ZHUANG3": {
				return "庄3".equals(item.getCodes());
			}
			case "XIAN1": {
				return "闲1".equals(item.getCodes());
			}
			case "XIAN2": {
				return "闲2".equals(item.getCodes());
			}
			case "XIAN3": {
				return "闲3".equals(item.getCodes());
			}
		}
		this.nums=1;
		return true;
	}
}
