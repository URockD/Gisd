import React, { Component } from "react";
import authService from "./api-authorization/AuthorizeService";

export class SerieData extends Component {
  static displayName = SerieData.name;

  constructor(props) {
    super(props);
    this.state = {
      seriesResponse: null,
      loading: true,
    };
  }

  componentDidMount() {
    this.populateSeriesData();
  }

  async populateSeriesData() {
    const token = await authService.getAccessToken();
    const response = await fetch("sieapi", {
      headers: !token ? {} : { Authorization: `Bearer ${token}` },
    });
    const data = await response.json();
    console.log(data);
    this.setState({ seriesResponse: data, loading: false });
  }

  static renderSeriesData(seriesResponse) {
    const series = seriesResponse;
    return (
      <div>
        <h5>{series.title}</h5>
        <table className="table table-sm table-hover table-dark">
          <thead>
            <tr>
              <th>Date</th>
              <th>Data</th>
            </tr>
          </thead>
          <tbody>
            {series.dataValues.map((item) => (
              <tr key={item.key}>
                <td>{item.key}</td>
                <td>{item.dataValue}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    );
  }

  render() {
    let contents = this.state.loading ? (
      <p>
        <em>Loading...</em>
      </p>
    ) : (
      SerieData.renderSeriesData(this.state.seriesResponse)
    );

    return <div>{contents}</div>;
  }
}
