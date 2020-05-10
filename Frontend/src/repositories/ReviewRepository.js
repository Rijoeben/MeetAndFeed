import Repository from './Repository'
const qs = require('querystring')
const recource = '/api/Review'
export default {
  CreateReview (content, score, userId) {
    const axiosConfig = {
      headers: {
        'Content-Type': 'application/json;charset=UTF-8',
        'Access-Control-Allow-Origin': '*'
      }
    }
    const requestBody = {
      content: content,
      score: score,
      userId: userId
    }
    return Repository.post(`${recource}?${qs.stringify(requestBody)}`, qs.stringify(requestBody), axiosConfig)
  }
}
