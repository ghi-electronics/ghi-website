import React, { useEffect } from 'react';

function BrevoForm() {
  useEffect(() => {
    // You might need to add Brevo's form script here.
    // For simple HTML, Brevo usually provides a small script
    // to handle form submission.
  }, []);

  
  const formMarkup = `
<iframe width="600" height="400" src="https://31f1477e.sibforms.com/v2/serve/MUIFAOM34Q39bLAOdXYsxqgLoJv_UyDM-x_p2iBp7nvR9SbkzgWUO4IZkXwS7clRwvBs6wJkSnuyqGwy19VFi53_jtN-bBb-_f7zoqD6uObzOHZiJfmEgfcA_fzly8tR1iNOkJY3TmRj3M6p2tqgl8gpd17rCo8M-hsMHU6Rbaxf83jXeD2HV92UKHapg54va8smtThsC-ddBJfT" frameborder="0" scrolling="auto" allowfullscreen style="display: block;margin-left: auto;margin-right: auto;max-width: 100%;"></iframe>
  `;



  return (
    <div dangerouslySetInnerHTML={{ __html: formMarkup }} />
  );
}

export default BrevoForm


