require 'rubygems'
require 'ruby-processing'
class Sketch<Processing::App
  def setup
    size 200,200
    background 255
    smooth
  end
  def draw
    
    r, g, b, a = random(255), random(255), random(255), random(255)
    diam = random(20)
    x, y = random(width), random(height)
    no_stroke
    fill r, g, b, a
    ellipse x, y, diam, diam

    
  end
  
  def mouse_pressed
    stroke 0
    fill 255,0,0,255
    rect_mode CENTER
    rect mouse_x, mouse_y, 5, 5
    
  end
  Sketch.new :title => "My Sketch"
end

