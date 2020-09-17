import React, { Component } from "react";
import ChartScope from "./ChartScope";
import authService from "./api-authorization/AuthorizeService";

export class Dashboard extends Component {
  static displayName = Dashboard.name;

  constructor(props) {
    super(props);
    this.state = {
      dataMemory: null,
      loading: true,
    };
  }

  componentDidMount() {
    this.populateSeriesData();
  }

  async populateSeriesData() {
    const token = await authService.getAccessToken();
    const response = await fetch("dashboard", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });

    const data = await response.json();
    this.setState({ dataMemory: data, loading: false });
  }

  static renderSeriesData(dataMemory) {
    return (
      <ChartScope
        data={dataMemory.data}
        labels={dataMemory.labels}
        title={dataMemory.title}
      />
    );
  }

  render() {
    let contents = this.state.loading ? (
      <p>
        <em>Loading...</em>
      </p>
    ) : (
      Dashboard.renderSeriesData(this.state.dataMemory)
    );

    return (
      <div>
        <h5>Dashboard</h5>
        {contents}
      </div>
    );
  }
}
