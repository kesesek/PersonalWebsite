// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('#scroll').click(function () {
        $('html, body').animate({
            scrollTop: $('#second-half').offset().top
        }, 500);
    });
});


document.addEventListener('DOMContentLoaded', function() {
    fetch('/api/article')
        .then(response => response.json())
        .then(articles => {
            const articlesContainer = document.getElementById('articles');
            articles.forEach(article => {
                const articleDiv = document.createElement('div');
                articleDiv.className = 'article-card';
                articleDiv.innerHTML = `<h2>${article.title}</h2><p>${article.content}</p>`;
                articlesContainer.appendChild(articleDiv);
            });
        })
        .catch(error => console.error('Error fetching articles:', error));
});