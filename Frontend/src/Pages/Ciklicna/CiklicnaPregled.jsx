import React, { useState, useEffect } from 'react';
import { getCiklicna } from './services/HttpService';  // Pretpostavimo da se funkcija nalazi ovdje

const CiklicnaPregled = ({ rows, cols }) => {
    const [matrixData, setMatrixData] = useState([]);

    const fetchCiklicnaData = async () => {
        const data = await getCiklicna(rows, cols);
        setMatrixData(data);
    };

    return (
        <div>
            <button onClick={fetchCiklicnaData}>Generate Spiral Matrix from API</button>
            <div style={{ display: 'grid', gridTemplateColumns: `repeat(${cols}, 50px)`, gap: '5px', marginTop: '20px' }}>
                {matrixData.map((ciklicna, index) => (
                    <div
                        key={index}
                        style={{
                            width: '50px',
                            height: '50px',
                            display: 'flex',
                            alignItems: 'center',
                            justifyContent: 'center',
                            backgroundColor: ciklicna.Boja === 'siva' ? 'gray' : 'black',
                            color: 'white',
                            border: '1px solid white'
                        }}>
                        {ciklicna.Broj}
                    </div>
                ))}
            </div>
        </div>
    );
};

export default CiklicnaPregled;


