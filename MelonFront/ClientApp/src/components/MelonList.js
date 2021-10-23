import React, { Component } from 'react';

export class MelonList extends Component {
    static displayName = MelonList.name;

  constructor(props) {
    super(props);
    this.state = { forecasts: [], loading: true };
  }

  componentDidMount() {
    this.populateWeatherData();
  }

  static renderForecastsTable(forecasts) {
    return (
      <table className='table table-striped' aria-labelledby="tabelLabel">
        <thead>
          <tr>
            <th>ばんごう</th>
            <th>めろん報告日</th>
            <th>重さ(kg)</th>
            <th>形状</th>
            <th>等級</th>
          </tr>
        </thead>
        <tbody>
          {forecasts.map(forecast =>
              <tr key={forecast.date}>
              <td>{forecast.id}</td>
              <td>{forecast.date}</td>
              <td>{forecast.temperatureC}</td>
              <td>{forecast.temperatureF}</td>
              <td>{forecast.summary}</td>
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
        : MelonList.renderForecastsTable(this.state.forecasts);

    return (
      <div>
        <h1 id="tabelLabel" >報告済みメロン</h1>
        <p>組合に連絡したメロンの一覧です</p>
        {contents}
      </div>
    );
  }

  async populateWeatherData() {
    const response = await fetch('weatherforecast');
    const data = await response.json();
    this.setState({ forecasts: data, loading: false });
  }
}
