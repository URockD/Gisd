import React, { Component } from "react";

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div className="jumbotron jumbotron-fluid">
        <div className="container">
          <h1 className="display-4">Challenge!</h1>
          <p className="lead">I like to use React and WebApi</p>
          <p className="lead">Let's started</p>
        </div>
      </div>
    );
  }
}
