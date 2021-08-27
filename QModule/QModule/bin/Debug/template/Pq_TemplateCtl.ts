import BaseCtl from "../../base/BaseCtl";
import Pq_TemplateCmd from "./Pq_TemplateCmd";
import Pq_TemplateProxy from "./Pq_TemplateProxy";
import Pq_TemplateUi from "./Pq_TemplateUi";

export default class Pq_TemplateCtl extends BaseCtl{
    public static NAME:string='Pq_TemplateController';
    private Proxy:Pq_TemplateProxy;
    protected script:Pq_TemplateUi;
    constructor(){
        super(Pq_TemplateCmd.MODULE_NAME);
    }
    public execute(param:Object=null,type:string=null){
        if(!this.Proxy)this.Proxy=this.getProxy(Pq_TemplateProxy.NAME);
        switch(type){
            case Pq_TemplateCmd.SHOW_WINDOW:
                this.show();
            break;
            case Pq_TemplateCmd.CLOSE_WINDOW:
                this.close();
            break;
        }
    }
	protected show(){
		super.show();
	}
    public logic(){
        
    }
}