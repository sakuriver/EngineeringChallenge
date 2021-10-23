import React, { Component } from 'react';
import { BrowserRouter as Router, Route, Switch, Redirect } from 'react-router-dom'
import GroupIcon from './images/MelonIcon.png';

export class Home extends Component {
  static displayName = Home.name;
  

  melonlistClick = () => {
    this.props.history.push("/melon-list");
  }

  melonreportClick = () => {
    this.props.history.push("/melon-report");
  }

  render () {
    return (
      <div>
        <h1>メロン組合へようこそ</h1>
        <img src={GroupIcon} />
        <p>毎年秋に収穫したメロンについて確認と報告できるよ</p>
            <button className="button" onClick={this.melonlistClick}>収穫メロンの確認</button>
        <div></div>
        <button className="button" onClick={this.melonreportClick}>メロンを報告</button>
      </div>
    );
  }
}
