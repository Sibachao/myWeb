<?php 
/**
 * 
 */

//require_once('core/Base.php');
class Admin extends CI_Controller
{
	public function index()
	{
		$this->load->view('admin/home/index');
		# code...
	}
}
?>