import Repository from './Repository'
const qs = require('querystring')
const recource = '/api/Post'
export default {
  getAllPosts () {
    return Repository.get(`${recource}`)
  },
  getPost (postId) {
    return Repository.get(`${recource}/${postId}`)
  },
  createPost (chef1, dish1, description1, date1, amount, userId1) {
    const axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    }
    const requestBody = {
      chef: chef1,
      dish: dish1,
      description: description1,
      date: date1,
      amountOfPeople: amount,
      userId: userId1
    }
    return Repository.post(`${recource}?${qs.stringify(requestBody)}`, qs.stringify(requestBody), axiosConfig)
  }
}
