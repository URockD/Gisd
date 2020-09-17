import React from "react";
import { Line as LineReact } from "react-chartjs-2";

const Line = ({ data, labels, title }) => {
  return (
    <div>
      <LineReact
        data={{
          labels,
          datasets: [
            {
              label: title,
              data,
              borderColor: ["rgba(54, 162, 235, 0.2)"],
              backgroundColor: ["rgba(54, 162, 235, 0.2)"],
              pointBackgroundColor: "rgba(54, 162, 235, 0.2)",
              pointBorderColor: "rgba(54, 162, 235, 0.2)",
            },
          ],
        }}
      />
    </div>
  );
};

export default Line;
