import React from "react";
import Line from "./chart/Line";

const ChartScope = ({ data, labels, title }) => {
  return (
    <div className="container">
      <p>{title}</p>
      <div className="row justify-content-md-center">
        <div className="col-12 col-md-10">
          <Line data={data} labels={labels} backgroundColor="" title={title} />
        </div>
      </div>
    </div>
  );
};

export default ChartScope;
