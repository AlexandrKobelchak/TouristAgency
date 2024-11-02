const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/api/ToutistTag",
    ],
    target: "http://localhost:5032",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
