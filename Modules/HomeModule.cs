using Nancy;
using Work.Objects;
using System.Collections.Generic;

namespace Work
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_job.cshtml"];
      Get["/view_all_jobs"] = _ => {
        List<Job> allJobs = Job.GetAll();
        return View["view_all_jobs.cshtml", allJobs];
      };
      Post["/job_added"] = _ => {
        Job newJob = new Job (Request.Form["new-company"], Request.Form["new-position"], Request.Form["new-time"]);
        newJob.Save();
        return View["job_added.cshtml", newJob];
      };
      Post["/jobs_cleared"] = _ => {
        Job.ClearAll();
        return View["jobs_cleared.cshtml"];
      };
    }
  }
}
