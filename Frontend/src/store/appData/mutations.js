
export const User = (state, userId) => {
    state.userId = userId,
    state.loggedIn = true
  }
  
  // src/store/showcase/state.js
  // Always use a function to return state if you use SSR
  export default function () {
    return {
      userId: '',
      loggedIn: false
    }
  }
