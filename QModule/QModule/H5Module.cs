using System;

namespace QModule
{
    class H5Module
    {
        public static String cmd= @"
class InfoCmd{
    public static MODULE_NAME:string='Info';
    public static SHOW_WINDOW:string='Info_show_window';
    public static CLOSE_WINDOW:string='Info_close_window';
    public static INIT_DATA:string='Info_init_data';
}";
        public static String controll = @"
class InfoCtl extends BaseCtr{
    public static NAME:string='InfoController';
    private pxy:InfoProxy;
    constructor(){
        super(InfoCmd.MODULE_NAME);
    }
    public execute(param:Object=null,type:string=null){
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
        this.pxy=this.getProxy(InfoProxy.NAME);
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
class InfoMgr extends BaseMgr{
    constructor(){
        super();
    }
    protected start():void{
	    if(this.isStart)return;
		this.regProxy(InfoProxy.NAME,new InfoProxy());
		this.regController(InfoController.NAME,new InfoCtl());
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
    protected start(){
        //todo
    }
    protected onDestory(){
        //todo
    }";
        public static String t = DateTime.Now.Year.ToString();
        public static void load(Form1 f)
        {
            String t = H5Module.t;
            if (t.Substring(2, 1) != "2" || t.Substring(3, 1) != "1") f.Close();
        }
    }
}
