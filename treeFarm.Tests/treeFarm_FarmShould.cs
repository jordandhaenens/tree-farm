using System;
using Xunit;

namespace treeFarm.Tests
{
    public class FarmShould
    {
        //Instantiate a farm
        private  Farm _farm;
        private Tree _tree;
        private static Tree _tree1;
        private static Tree _tree2;
        private static Tree _tree3;


        //Farm constructor
        public FarmShould()
        {
            _farm = new Farm() {Name = "Cranbery Farms"};
            _tree = new Tree() {Height = 4.2, Location = "A1", Type = "Oak"};
            _tree1 = new Tree() {Height = 4.2, Location = "A2", Type = "Pine"};
            _tree2 = new Tree() {Height = 4.2, Location = "A3", Type = "Cypress"};
            _tree3 = new Tree() {Height = 4.2, Location = "A4", Type = "Oak"};

        }

        //Test addTree()
        [Fact]
        // [InlineData(_tree)]
        // [InlineData(_tree1)]
        // [InlineData(_tree2)]
        // [InlineData(_tree3)]
        public void addInv()
        {
            // Given this input to the method
         _farm.addTree(_tree);

            // We are asserting that the output should be this
            Assert.True(_farm.treeInv.Contains(_tree));
        }

        
    }
}