import React from "react";
import { Bar as BarReact } from "react-chartjs-2";

const Bar = ({ data, labels, backgroundColor, title }) => {
  return (
    <div>
      <BarReact
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

export default Bar;
