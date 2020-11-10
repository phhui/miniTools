class InfoMgr extends BaseMgr{
    constructor(){
        super();
    }
    protected start():void{
	    if(this.isStart)return;
		this.regProxy(InfoProxy.NAME,new InfoProxy());
		this.regController(InfoController.NAME,new InfoController());
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
				this.control(InfoController.NAME,param,type);
			break;
		}
	}
}