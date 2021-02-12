import React from 'react';
import './CommonSection.css';
import { Button } from '../Button/Button'

function CommonSection({
  lightBg,
  topLine,
  lightText,
  lightTextDesc,
  headline,
  description,
  buttonLabel,
  img,
  alt,
  imgStart
}) {

  const showText = () => {
    alert('Dummy Button Here');
  }

  return (
    <>
      <div
        className={lightBg ? 'home_common-section' : 'home_common-section darkBg'}
      >
        <div className='container'>
          <div
            className='row home_common-row'
            style={{
              display: 'flex',
              flexDirection: imgStart === 'start' ? 'row-reverse' : 'row'
            }}
          >
            <div className='col'>
              <div className='home_common-text-wrapper'>
                <div className='top-line'>{topLine}</div>
                <h1 className={lightText ? 'heading' : 'heading dark'}>
                  {headline}
                </h1>
                <p
                  className={
                    lightTextDesc
                      ? 'home_common-subtitle'
                      : 'home_common-subtitle dark'
                  }
                >
                  {description}
                </p>
                <Button buttonSize='btn--wide' buttonColor='blue' onClick={showText}>
                  {buttonLabel}
                </Button>
              </div>
            </div>
            <div className='col'>
              <div className='home_common-img-wrapper'>
                <img src={img} alt={alt} className='home_common-img' />
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
}

export default CommonSection;
