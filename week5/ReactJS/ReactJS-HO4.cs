import React from 'react';

class Posts extends React.Component {
  constructor(props) {
    super(props);
    this.state = { posts: [] };
  }

  loadPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
      .then(res => res.json())
      .then(data => this.setState({ posts: data }));
  }

  componentDidMount() {
    this.loadPosts(); // Fetch posts when component mounts [cite: 302]
  }

  componentDidCatch(error, info) {
    alert("Error caught: " + error); // Error handling [cite: 306]
  }

  render() {
    return (
      <div>
        {this.state.posts.map(post => (
          <div key={post.id}>
            <h2>{post.title}</h2>
            <p>{post.body}</p>
          </div>
        ))}
      </div>
    );
  }
}
export default Posts;