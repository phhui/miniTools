import BaseUi from "../../base/BaseUi";
import Register from "../../../Script/core/Register";
import Pq_TemplateMgr from "./Pq_TemplateMgr";

const {ccclass, property} = cc._decorator;
@ccclass
export default class Pq_TemplateUi extends BaseUi{
    constructor(){
        super();
        Register.regModule(Pq_TemplateMgr);
    }
}