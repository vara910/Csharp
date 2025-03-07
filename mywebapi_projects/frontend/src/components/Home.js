import React from 'react';

function Home() {
  return (
    <div>
      <h1 className="text-center text-primary">Welcome to my page y'all!!</h1>
      <p className="text-center">This is a simple example </p>
      
      <div className="row">
        <div className="col-md-4">
          <div className="card p-3 shadow-sm">
            <h3>hello</h3>
            <p>enter</p>
            <button className="btn btn-primary">nokku</button>
          </div>
        </div>
        
        <div className="col-md-4">
          <div className="card p-3 shadow-sm">
            <h3>hello</h3>
            <p>enter</p>
            <button className="btn btn-success">ha explore chey</button>
          </div>
        </div>

        <div className="col-md-4">
          <div className="card p-3 shadow-sm">
            <h3>all</h3>
            <p>enter!</p>
            <button className="btn btn-danger">Click</button>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Home;
