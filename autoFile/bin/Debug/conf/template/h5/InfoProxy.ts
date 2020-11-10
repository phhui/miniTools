class InfoProxy extends BaseProxy{
    static NAME:string="InfoProxy";
	public execute(param:any=null, type:string=null):void{
		switch(type){
			case InfoCmd.INIT_DATA:
				this.initData();
				break;
		}
	}
    private initData(){

    }
}