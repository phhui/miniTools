import SysCmd from "../../../Script/public/SysCmd";
import BaseMgr from "../../base/BaseMgr";
import Pq_TemplateCmd from "./Pq_TemplateCmd";
import Pq_TemplateCtl from "./Pq_TemplateCtl";
import Pq_TemplateProxy from "./Pq_TemplateProxy";
const {ccclass} = cc._decorator;

@ccclass
export default class Pq_TemplateMgr extends BaseMgr {
    protected start():void{
	    if(this.isStart)return;
		this.isStart=true;
		this.regProxy(Pq_TemplateProxy.NAME,new Pq_TemplateProxy());
		this.regController(Pq_TemplateCtl.NAME,new Pq_TemplateCtl());
	}
	protected get EventList():Array<any>{
		return [Pq_TemplateCmd.SHOW_WINDOW,
                Pq_TemplateCmd.CLOSE_WINDOW,
                Pq_TemplateCmd.MODULE_NAME,
                Pq_TemplateCmd.INIT_DATA,
                SysCmd.INIT_DATA];
	}
	protected execute(type:string, param:Object=null):void{
		switch(type){
            case SysCmd.INIT_DATA:
			case Pq_TemplateCmd.INIT_DATA:
				this.proxy(Pq_TemplateProxy.NAME,param,type);
			break;
			default:
				this.control(Pq_TemplateCtl.NAME,param,type);
			break;
		}
	}
}
