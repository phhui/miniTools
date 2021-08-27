import BaseCtl from "../../base/BaseCtl";
import Pq_TemplateCmd from "./Pq_TemplateCmd";
import Pq_TemplatePxy from "./Pq_TemplatePxy";
import Pq_TemplateUi from "./Pq_TemplateUi";

export default class Pq_TemplateCtl extends BaseCtl{
    public static NAME:string='Pq_TemplateController';
    private pxy:Pq_TemplatePxy;
    protected script:Pq_TemplateUi;
    constructor(){
        super(Pq_TemplateCmd.MODULE_NAME);
    }
    public execute(param:Object=null,type:string=null){
        if(!this.pxy)this.pxy=this.getProxy(Pq_TemplatePxy.NAME);
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