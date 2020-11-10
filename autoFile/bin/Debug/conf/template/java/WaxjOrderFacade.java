package com.chaos.gaia.game.business.facade.lottery.impl;

import org.springframework.stereotype.Component;

import com.chaos.gaia.game.business.facade.lottery.IWaxjOrderFacade;
import com.chaos.gaia.game.business.service.lottery.IWaxjBetOrderService;
import com.chaos.gaia.lottery.IBetInfo;
import com.chaos.gaia.lottery.validator.GameValidator;
import com.chaos.gaia.lottery.validator.WAXJValidator;
@Component
public class WaxjOrderFacade extends BetClassicOrderFacade<IWaxjBetOrderService> implements IWaxjOrderFacade {

	public WaxjOrderFacade() {
		playId = "WAXJ";
	}

	@Override
	protected GameValidator validBetItem(IBetInfo item) {
		item.setTimes(1);
		return new WAXJValidator(item);
	}

}
