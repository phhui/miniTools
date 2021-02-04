using System;

namespace QModule.template
{
    class Cocos
    {
        public static String cmd = @"
export default class InfoCmd{
    public static MODULE_NAME:string='Info';
    public static SHOW_WINDOW:string='Info_show_window';
    public static CLOSE_WINDOW:string='Info_close_window';
    public static INIT_DATA:string='Info_init_data';
}";
        public static String controll = @"
import BaseCtr from '../base/BaseController';
import FightProxy from './FightProxy';
export default class InfoCtl extends BaseCtr{
    public static NAME:string='InfoController';
    private pxy:InfoProxy;
    constructor(){
        super(InfoCmd.MODULE_NAME);
    }
    public execute(param:Object=null,type:string=null){
        if(!this.pxy)this.pxy=this.getProxy(InfoProxy.NAME);
        switch(type){
            case InfoCmd.SHOW_WINDOW:
                this.show();
            break;
            case InfoCmd.CLOSE_WINDOW:
                this.close();
            break;
        }
    }
    private init(){
        super.init();
        this.pxy.initData();
    }
    private logic(){
        //todo
    }
    private onClick(e:cc.Event.EventTouch){
        //todo
    }
}";
        public static String mgr = @"
import BaseMgr from '../base/BaseMgr';
import FightCtl from './FightCtl';
import FightProxy from './FightProxy';
export default class InfoMgr extends BaseMgr{
    constructor(){
        super();
    }
    protected start():void{
	    if(this.isStart)return;
		this.regProxy(InfoProxy.NAME,new InfoProxy());
		this.regController(InfoCtl.NAME,new InfoCtl());
		this.isStart=true;
	}
	protected get EventList():Array<any>{
		return [InfoCmd.SHOW_WINDOW,
				InfoCmd.CLOSE_WINDOW,
                InfoCmd.MODULE_NAME,
				InfoCmd.INIT_DATA];
	}
	protected execute(type:string, param:Object=null):void{
		switch(type){
			case InfoCmd.INIT_DATA:
				this.proxy(InfoProxy.NAME,param,type);
			break;
			default:
				this.control(InfoCtl.NAME,param,type);
			break;
		}
	}
}";
        public static String proxy = @"
import BaseProxy from '../base/BaseProxy';
export default class InfoProxy extends BaseProxy{
    static NAME:string='InfoProxy';
	public execute(param:any= null, type:string= null):void{
		switch(type){
			case InfoCmd.INIT_DATA:
				this.initData();
				break;
		}
    }
    public initData()
    {

    }
}";
        public static String ui = @"
import BaseUi from '../base/BaseUi';
const {ccclass, property} = cc._decorator;
@ccclass
export default class InfoUi extends BaseUi{
    @property(cc.Prefab)
    private pf:cc.Prefab=null;
    @property(cc.Node)
    private nd:cc.Node=null;
    start(){
        //todo
    }
    public bindData(data){
        //todo
    }
    destory(){
        //todo
    }
}";
    }
}
