# coding: utf-8
require 'enum_0'

RSpec.describe Enum0 do
  it 'parses test properly' do
    r = Enum0.from_file('src/enum_0.bin')

    expect(r.pet_1).to eq :animal_cat
    expect(r.pet_2).to eq :animal_chicken
  end
end
