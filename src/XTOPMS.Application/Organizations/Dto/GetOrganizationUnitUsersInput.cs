using System.ComponentModel.DataAnnotations;
using Abp.Runtime.Validation;
using XTOPMS.Application.Dto;

namespace XTOPMS.Organizations.Dto
{
    public class GetOrganizationUnitUsersInput : PagedSortedInputDto, IShouldNormalize
    {
        [Range(1, long.MaxValue)]
        public long Id { get; set; }

        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Name,Surname";
            }
        }
    }
}