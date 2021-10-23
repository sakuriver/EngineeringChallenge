import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { MelonList } from './components/MelonList';
import { MelonReport } from './components/MelonReport';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/melon-list' component={MelonList} />
        <Route path='/melon-report' component={MelonReport} />
      </Layout>
    );
  }
}
