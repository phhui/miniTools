package com.chaos.gaia.game.business.service.lottery.impl;

import java.util.ArrayList;
import java.util.List;

import org.springframework.stereotype.Service;

import com.chaos.gaia.game.business.domain.GamePlayQuota;
import com.chaos.gaia.game.business.domain.PubSiteGame;
import com.chaos.gaia.game.business.service.lottery.IWaxjBetOrderService;
import com.chaos.gaia.game.business.vo.lottery.GameTemplate;
import com.chaos.gaia.game.business.vo.lottery.bet.classic.ClassicBetInput;
import com.chaos.gaia.game.business.vo.lottery.bet.classic.ClassicBetPlay;
import com.chaos.gaia.game.business.vo.lottery.bet.classic.ClassicLayout;
import com.chaos.gaia.game.business.vo.lottery.bet.classic.InputAreas;
import com.chaos.gaia.game.business.vo.lottery.bet.live.LiveBetLayout;
import com.chaos.gaia.game.business.vo.lottery.bet.live.LiveBetPlay;
import com.chaos.gaia.modules.service.ServiceException;

@Service
public class WaxjBetOrderService extends BetClassicOrderService implements IWaxjBetOrderService {
	public WaxjBetOrderService() {
		playId = "WAXJ";
	}

	@Override
	protected List<LiveBetPlay> getLiveData(GameTemplate gametemplate, PubSiteGame sitegame, List<GamePlayQuota> list)
			throws ServiceException {
		List<LiveBetPlay> result = new ArrayList<>();

		for (int i = 0; i < list.size(); i++) {
			GamePlayQuota quota = list.get(i);
			if (quota.getHasChild()) {// 是否有第二层级
				for (GamePlayQuota gquota1 : quota.getQuotaList()) {
					LiveBetPlay betplay = new LiveBetPlay();
					betplay.setTitle(gquota1.getPlayName());
					if (gquota1.getHasChild()) {// 第三层级
						for (GamePlayQuota gquota2 : gquota1.getQuotaList()) {
							betplay.getList().add(new LiveBetLayout(gquota2.getPlayId(), gquota2.getShowName(),
									gquota2.getBetName(), gquota2.getOdds(), gquota2.getPlayMethod()));
						}
						result.add(betplay);
					}
				}
			}
		}
		return result;
	}

	@Override
	protected List<ClassicBetPlay> getPageData(GameTemplate gametemplate, PubSiteGame sitegame,
			List<GamePlayQuota> list) throws ServiceException {

		List<ClassicBetPlay> result = new ArrayList<>();
		// 判断首选
		for (int i = 0; i < list.size(); i++) {
			GamePlayQuota quota = list.get(i);
			ClassicBetPlay betplay = new ClassicBetPlay(quota.getPlayId());
			betplay.setTitle(quota.getPlayName());

			if (quota.getHasChild()) {// 是否有第二层级

				InputAreas area = new InputAreas();
				for (GamePlayQuota gquota1 : quota.getQuotaList()) {
					if (gquota1.getHasChild()) {// 第三层级
						int len = 2;
						int mlen = 2;
						ClassicLayout layout = new ClassicLayout(gquota1.getPlayId(), len, false);
						layout.setMlen(mlen);
						layout.setCaption(gquota1.getPlayName());
						for (GamePlayQuota gquota2 : gquota1.getQuotaList()) {
							layout.getList().add(new ClassicBetInput(gquota2.getPlayId(), gquota2.getShowName(),
									gquota2.getBetName(), gquota2.getOdds(), gquota2.getPlayMethod()));
						}

						area.getLayout().add(layout);
					}
				}
				betplay.setArea(area);

			}
			result.add(betplay);
		}
		return result;
	}
	
}
