using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nonogram.Models
{

    public enum TagType
    {
        None,
        Auth,
        Guest,
        Load
    }

    public class ControlTag
    {
        public List<TagType> tags = [];
        public ControlTag() { }
        public ControlTag(List<TagType> tags) => this.tags = tags;
    }

    //TODO: Enum?
    //public interface ILoadType
    //{
    //    public void LoadType();
    //}
}
