import React from 'react';
import CommonSection from '../CommonSection/CommonSection';
import { ObjHome, ObjOne } from './Data';

function Home() {
  return (
    <>
      <CommonSection {...ObjHome} />
      <CommonSection {...ObjOne} />
    </>
  );
}

export default Home;
