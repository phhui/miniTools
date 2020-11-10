class InfoController extends BaseController{
    static NAME:string="InfoController";
    private pxy:InfoProxy;
    private bgDict:Object;
    private starType:number=0;
    constructor(){
        super();
        this.btnNameList.push("btn_close");
        this.funcList.push(this.btnClick);
        this.target = this;
    }
    public execute(param:Object=null,type:string=null){
        switch(type){
            case InfoCmd.SHOW_WINDOW:
                this.showWindow();
            break;
            case InfoCmd.CLOSE_WINDOW:
                this.closeWindow();
            break;
            case InfoCmd.MODULE_NAME:
                this.initView();
            break;
        }
    }
    private initView(){
        this.ui=new InfoView();
        this.pxy=this.getProxy(InfoProxy.NAME);
        this.inited=true;
        this.showWindow();
    }
    private showWindow(){
        if(!this.inited){
            this.call(SysCmd.LOAD_MODULE_RES,InfoCmd.MODULE_NAME);
            return;
        }
        this.call(SysCmd.ADD_TO_STAGE,this.ui);
    }
    private closeWindow(){
	    this.call(SysCmd.REMOVE_FROM_STAGE,this.ui);
    }
    private btnClick(type:string,target:any){
        this.closeWindow();
    }
}