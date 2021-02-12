import React from 'react';
import CommonSection from '../CommonSection/CommonSection';
import { ObjAboutUs } from './Data';

function AboutUs() {
  return (
    <>
      <CommonSection {...ObjAboutUs} />
    </>
  );
}

export default AboutUs;
