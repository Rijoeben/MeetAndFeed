import PostRepository from './postsRepository'
import UserRepository from './UserRepository'

const repositories = {
  posts: PostRepository,
  user: UserRepository
}

export const RepositoryFactory = {
  get: name => repositories[name]
}
