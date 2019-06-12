<?php

class Home extends CI_Controller
{
	
	public function __construct()
	{
		parent::__construct();
		$this->load->helper('cookie');
	}
	public function welcome(){
		echo "Hello";
	}

	public function goodbye(){
		echo "bye";
	}

	public function loadDB(){
		$this->load->database();
	}

	public function truyen(){
		$data = array();
		$id = $this->uri->segment('3');
		
		if ($id !=null) {
			# code...
			$data['string'] = $id;
		}
		else $data['string'] = '1';
		$this->load->view('home/truyen',$data);
	}

	public function loadCk(){
       set_cookie("name","2","10");
       echo "Congragulatio Cookie Set";
	}

}