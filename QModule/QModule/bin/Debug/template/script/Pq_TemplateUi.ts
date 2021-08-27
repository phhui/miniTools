import BaseUi from "../../base/BaseUi";
import Pq_TemplateMgr from "./Pq_TemplateMgr";

const {ccclass, property} = cc._decorator;
@ccclass
export default class Pq_TemplateUi extends BaseUi{
    constructor(){
        super();
        if(!Pq_TemplateMgr.isCreated)new Pq_TemplateMgr();
    }
}