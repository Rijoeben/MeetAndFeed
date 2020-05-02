import Repository from './Repository'

const recource = '/Post'
export default {
  getAllPosts () {
    return Repository.get(`${recource}`)
  },
  getPost (postId) {
    return Repository.get(`${recource}/${postId}`)
  },
  createPost (dish, description, date) {
    const params = {
      dish: dish,
      description: description,
      date: date,
      amountOfPeople: 2
    }
    return Repository.post(`${recource}`, params)
  }
}
