import { observable, action } from 'mobx';
//import * as React from "react";



class LinkStore {

    //------------------------------------
    @observable intentionsTotal = 0

    @action setIntentionsTotal(num:number) {
        this.intentionsTotal = num
    }
    //------------------------------------
    @observable obligationsTotal = 0

    @action setObligationsTotal(num:number) {
        this.obligationsTotal = num
    }
    //------------------------------------
    @observable tag = {}

    @action setTag(tag:any) {
        this.tag = tag
    }
    // //----------------h2o--------------------
    // @observable intentionsTotalH2o = 0
    //
    // @action setIntentionsTotalH2o(num:number) {
    //     this.intentionsTotalH2o = num
    // }
    // //----------------h2o--------------------
    // @observable obligationsTotalH2o = 0
    //
    // @action setObligationsTotalH2o(num:number) {
    //     this.obligationsTotalH2o = num
    // }

}

export const linkStore=new LinkStore()
//export const LinkContext = React.createContext(linkStore);
