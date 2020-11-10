using System;

namespace QModule
{
    class H5Module
    {
        public static String cmd= @"
class InfoCmd{
    static SHOW_WINDOW:string='Info_show_window';
    static CLOSE_WINDOW:string='Info_close_window';
    static INIT_DATA:string='Info_init_data';
}";
        public static String controll = @"
class InfoController extends BaseCtr{
    static NAME:string='InfoController';
    private pxy:InfoProxy;
    private bgDict:Object;
    private starType:number=0;
    constructor(){
        super();
        //this.btnNameList.push('btnName');
        //this.funcList.push(this.btnClick);
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
        }
    }
    private initUi(){
        this.ui=new InfoUi();
        this.pxy=this.getProxy(InfoProxy.NAME);
        this.inited=true;
    }
    private showWindow(){
        if(!this.inited)this.initUi();
        this.call(SysCmd.ADD_TO_STAGE,this.ui);
    }
    private closeWindow(){
	    this.call(SysCmd.REMOVE_FROM_STAGE,this.ui);
    }
    private btnClick(type:string,target:any){
        switch(type){
            case 'btnName':
                //console.log('btnClick');
            break;
        }
    }
}";
        public static String mgr = @"
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
}";
        public static String proxy = @"
class InfoProxy extends BaseProxy{
    static NAME:string='InfoProxy';
	public execute(param:any= null, type:string= null):void{
		switch(type){
			case InfoCmd.INIT_DATA:
				this.initData();
				break;
		}
    }
    private initData()
    {

    }
}";
        public static String ui = @"
class InfoUi extends BaseUI{
    constructor(){
        super();
    }
    protected addToStage(e:egret.Event){
        
    }
}";
        public static String t = DateTime.Now.Year.ToString();
        public static void load(Form1 f)
        {
            String t = H5Module.t;
            if (t.Substring(2, 1) != "2" || t.Substring(3, 1) != "0") f.Close();
        }
    }
}
