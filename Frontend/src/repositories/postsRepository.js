import Repository from './Repository'

const recource = '/Post'
export default {
  getAllPosts () {
    return Repository.get(`${recource}`)
  },
  getPost (postId) {
    return Repository.get(`${recource}/${postId}`)
  },
  createPost (chef1, dish1, description1, date1, userId1) {
    return Repository.post(`${recource}`, {
      params: {
        chef: chef1,
        dish: dish1,
        description: description1,
        date: date1,
        amountOfPeople: 2,
        userId: userId1
      }
    })
  }
}
