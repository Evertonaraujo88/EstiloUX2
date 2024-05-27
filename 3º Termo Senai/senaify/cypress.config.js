const { defineConfig } = require("cypress");

module.exports = defineConfig({
  e2e: {
    testIsolation: false,
    reactNativeHotReaload: false,
    viewportHeight: 414,
    viewportHeight:896,
    baseUrl: "http://localhost:8081"
  },
});
