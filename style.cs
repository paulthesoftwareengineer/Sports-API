html {
  height: 100%;
}
body {
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100%;
  background-size: cover;
  font-family: sans-serif;
}
#overlay {
  background: rgba(147, 135, 242, 0.9);
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  z-index: -1;
}
#cocktail {
  max-width: 350px;
  text-align: center;
  padding: 30px 30px 12px 30px;
  color: #fff;
  background-color: #7766d7;
  border: 4px solid #9387f2;
  border-radius: 5px;
}
#cocktail h1 {
  margin: 0 0 15px 0;
  text-transform: uppercase;
}
#cocktail img {
  max-width: 300px;
  border: 6px solid #fff;
  border-radius: 150px;
}
#cocktail ul {
  list-style: none;
  margin: 0;
  padding: 0;
}
#cocktail li {
  padding: 15px 0;
  font-size: 18px;
}
#cocktail li:not(:last-of-type) {
  border-bottom: 1px solid #fff;
}