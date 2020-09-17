import React from "react";
import { Pie as PieReact } from "react-chartjs-2";

const Pie = ({ data, labels, backgroundColor, title }) => {
  return (
    <div>
      <PieReact
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

export default Pie;
