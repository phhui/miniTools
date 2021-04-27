using System;

namespace QModule.template
{
    class Cocos
    {
        public static String cmd = @"
export default class Pq_TemplateCmd{
    public static MODULE_NAME:string='Pq_Template';
    public static SHOW_WINDOW:string='Pq_Template_show_window';
    public static CLOSE_WINDOW:string='Pq_Template_close_window';
    public static INIT_DATA:string='Pq_Template_init_data';
}";
        public static String controll = @"
import BaseCtl from '../base/BaseCtl';
import Pq_TemplateCmd from './Pq_TemplateCmd';
import Pq_TemplateProxy from './Pq_TemplateProxy';
export default class Pq_TemplateCtl extends BaseCtl{
    public static NAME:string='Pq_TemplateController';
    private pxy:Pq_TemplateProxy;
    constructor(){
        super(Pq_TemplateCmd.MODULE_NAME);
    }
    public execute(param:Object=null,type:string=null){
        if(!this.pxy)this.pxy=this.getProxy(Pq_TemplateProxy.NAME);
        switch(type){
            case Pq_TemplateCmd.SHOW_WINDOW:
                this.show();
            break;
            case Pq_TemplateCmd.CLOSE_WINDOW:
                this.close();
            break;
        }
    }
    public init(){
        super.init();
        this.pxy.initData();
    }
    public logic(){
        //todo
    }
    public onClick(e:cc.Event.EventTouch){
        //todo
    }
}";
        public static String mgr = @"
import BaseMgr from '../base/BaseMgr';
import Pq_TemplateCmd from './Pq_TemplateCmd';
import Pq_TemplateCtl from './Pq_TemplateCtl';
import Pq_TemplateProxy from './Pq_TemplateProxy';
export default class Pq_TemplateMgr extends BaseMgr{
    constructor(){
        super();
    }
    protected start():void{
	    if(this.isStart)return;
		this.regProxy(Pq_TemplateProxy.NAME,new Pq_TemplateProxy());
		this.regController(Pq_TemplateCtl.NAME,new Pq_TemplateCtl());
		this.isStart=true;
	}
	protected get EventList():Array<any>{
		return [Pq_TemplateCmd.SHOW_WINDOW,
				Pq_TemplateCmd.CLOSE_WINDOW,
                Pq_TemplateCmd.MODULE_NAME,
				Pq_TemplateCmd.INIT_DATA];
	}
	protected execute(type:string, param:Object=null):void{
		switch(type){
			case Pq_TemplateCmd.INIT_DATA:
				this.proxy(Pq_TemplateProxy.NAME,param,type);
			break;
			default:
				this.control(Pq_TemplateCtl.NAME,param,type);
			break;
		}
	}
}";
        public static String proxy = @"
import BaseProxy from '../base/BaseProxy';
import Pq_TemplateCmd from './Pq_TemplateCmd';
export default class Pq_TemplateProxy extends BaseProxy{
    static NAME:string='Pq_TemplateProxy';
	public execute(param:any= null, type:string= null):void{
		switch(type){
			case Pq_TemplateCmd.INIT_DATA:
				this.initData();
				break;
		}
    }
    public initData()
    {

    }
}";
        public static String ui= @"
import BaseUi from '../base/BaseUi';
const {ccclass, property} = cc._decorator;
@ccclass
export default class Pq_TemplateUi extends BaseUi{
    start(){
        //todo
    }
    onDestory(){
        //todo
    }
}";
        public static String prefab = @"[
  {
    '__type__': 'cc.Prefab',
    '_name': '',
    '_objFlags': 0,
    '_native': '',
    'data': {
      '__id__': 1
    },
    'optimizationPolicy': 0,
    'asyncLoadAssets': false,
    'readonly': false
  },
  {
    '__type__': 'cc.Node',
    '_name': 'Pq_Template',
    '_objFlags': 0,
    '_parent': null,
    '_children': [],
    '_active': true,
    '_components': [],
    '_prefab': {
      '__id__': 2
    },
    '_opacity': 255,
    '_color': {
      '__type__': 'cc.Color',
      'r': 255,
      'g': 255,
      'b': 255,
      'a': 255
    },
    '_contentSize': {
      '__type__': 'cc.Size',
      'width': 0,
      'height': 0
    },
    '_anchorPoint': {
      '__type__': 'cc.Vec2',
      'x': 0.5,
      'y': 0.5
    },
    '_trs': {
      '__type__': 'TypedArray',
      'ctor': 'Float64Array',
      'array': [
        0,
        0,
        0,
        0,
        0,
        0,
        1,
        1,
        1,
        1
      ]
    },
    '_eulerAngles': {
      '__type__': 'cc.Vec3',
      'x': 0,
      'y': 0,
      'z': 0
    },
    '_skewX': 0,
    '_skewY': 0,
    '_is3DNode': false,
    '_groupIndex': 0,
    'groupIndex': 0,
    '_id': ''
  },
  {
    '__type__': 'cc.PrefabInfo',
    'root': {
      '__id__': 1
    },
    'asset': {
      '__id__': 0
    },
    'fileId': 'f6zzOFxZhPnI7TuXgIIJlm',
    'sync': false
  }
]";
    }
}
