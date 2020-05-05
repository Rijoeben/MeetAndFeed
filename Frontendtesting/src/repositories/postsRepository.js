import Repository from './Repository'

const recource = '/Post'
export default {
  getAllPosts () {
    return Repository.get(`${recource}`)
  },
  getPost (postId) {
    return Repository.get(`${recource}/${postId}`)
  },
  createPost (dish1, description1, date1) {
    const params = {
      dish: dish1,
      description: description1,
      date: date1,
      amountOfPeople: 2
    }
    return Repository.post(`${recource}`, JSON.stringify(params))
  }
}
