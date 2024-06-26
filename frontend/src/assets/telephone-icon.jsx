import React from "react";

function TelephoneIcon() {
  return (
    <svg
      xmlns="http://www.w3.org/2000/svg"
      width="1em"
      height="1em"
      viewBox="0 0 48 48"
    >
      <defs>
        <mask id="ipTPhoneTelephone0">
          <path
            fill="#555"
            stroke="#fff"
            strokeLinejoin="round"
            strokeWidth="4"
            d="M16.996 7.686a2 2 0 011.749 1.03l2.446 4.406a2 2 0 01.04 1.865l-2.356 4.714s.683 3.511 3.541 6.37c2.859 2.858 6.358 3.53 6.358 3.53l4.713-2.357a2 2 0 011.866.04l4.42 2.458A2 2 0 0140.8 31.49v5.073c0 2.584-2.4 4.45-4.848 3.624-5.028-1.697-12.833-4.927-17.78-9.874-4.946-4.947-8.177-12.751-9.873-17.78-.826-2.447 1.04-4.847 3.624-4.847z"
          ></path>
        </mask>
      </defs>
      <path
        fill="#919EAB"
        d="M0 0h48v48H0z"
        mask="url(#ipTPhoneTelephone0)"
      ></path>
    </svg>
  );
}

export default TelephoneIcon;
