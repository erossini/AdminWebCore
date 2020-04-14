using AdminWebCore.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminWebCore.Data
{
    /// <summary>
    /// Class DataGenerator.
    /// </summary>
    public class DataGenerator
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly AdminWebContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGenerator"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public DataGenerator(AdminWebContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            if (!_context.UserInfo.Any())
            {
                _context.UserInfo.Add(
                                    new UserInfo
                                    {
                                        UserId = 1,
                                        UserName = "enrico",
                                        Email = "enrico.rossini.uk@live.com",
                                        FirstName = "Enrico",
                                        LastName = "Rossini",
                                        Password = "enrico!1975"
                                    });

                _context.SaveChanges();
            }
        }
    }
}