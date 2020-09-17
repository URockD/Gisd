import React from "react";
import { Doughnut as DoughnutReact } from "react-chartjs-2";

const Doughnut = ({ data, labels, backgroundColor, title }) => {
  return (
    <div>
      <DoughnutReact
        data={{
          labels,
          datasets: [
            {
              label: title,
              data,
              backgroundColor,
            },
          ],
        }}
      />
    </div>
  );
};

export default Doughnut;
