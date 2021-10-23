import React, { Component } from 'react';
import GroupIcon from './images/MelonIcon.png';

export class MelonReport extends Component {
    static displayName = MelonReport.name;

  constructor(props) {
    super(props);
    this.state = { currentCount: 0 };
    this.incrementCounter = this.incrementCounter.bind(this);
  }

  incrementCounter() {
    this.setState({
      currentCount: this.state.currentCount + 1
    });
  }

  render() {
    return (
      <div>
        <h1>メロン報告         <img src={GroupIcon} /></h1>

        <p>メロンの内容を入力してください</p>

        <p aria-live="polite">重量(kg) : </p>
        <p aria-live="polite">形状 : </p>
        <p aria-live="polite">表皮色 : </p>
        <p aria-live="polite">等級 : </p>

        <button className="btn btn-primary" onClick={this.incrementCounter}>ほうこく</button>
      </div>
    );
  }
}
