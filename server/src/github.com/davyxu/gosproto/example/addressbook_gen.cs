// Generated by github.com/davyxu/gosproto/sprotogen
// DO NOT EDIT!
using System;
using Sproto;
using System.Collections.Generic;

namespace example
{

	public enum MyCar {
		
		Monkey = 0,
		
		Monk = 1,
		
		Pig = 2,
		
	}



	
	public class AddressBook : SprotoTypeBase {
		private static int max_field_count = 1;
		
		
		[SprotoHasField]
		public bool HasPerson{
			get { return base.has_field.has_field(0); }
		}
		
		private List<Person> _person; // tag 0
		public List<Person> person {
			get{ return _person; }
			set{ base.has_field.set_field(0,true); _person = value; }
		}
		
		
		public AddressBook() : base(max_field_count) {}
		
		public AddressBook(byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}
		
		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				
				case 0:
					this.person = base.deserialize.read_obj_list<Person>();
					break;
				
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}
		
		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			
			if (base.has_field.has_field (0)) {
				base.serialize.write_obj(this.person, 0);
			}
			

			return base.serialize.close ();
		}
	}

	
	public class MyData : SprotoTypeBase {
		private static int max_field_count = 10;
		
		
		[SprotoHasField]
		public bool HasName{
			get { return base.has_field.has_field(0); }
		}
		
		private string _name; // tag 0
		public string name {
			get{ return _name; }
			set{ base.has_field.set_field(0,true); _name = value; }
		}
		
		[SprotoHasField]
		public bool HasType{
			get { return base.has_field.has_field(1); }
		}
		
		private MyCar _Type; // tag 1
		public MyCar Type {
			get{ return _Type; }
			set{ base.has_field.set_field(1,true); _Type = value; }
		}
		
		[SprotoHasField]
		public bool HasInt32{
			get { return base.has_field.has_field(2); }
		}
		
		private Int32 _Int32; // tag 2
		public Int32 Int32 {
			get{ return _Int32; }
			set{ base.has_field.set_field(2,true); _Int32 = value; }
		}
		
		[SprotoHasField]
		public bool HasUint32{
			get { return base.has_field.has_field(3); }
		}
		
		private UInt32 _Uint32; // tag 3
		public UInt32 Uint32 {
			get{ return _Uint32; }
			set{ base.has_field.set_field(3,true); _Uint32 = value; }
		}
		
		[SprotoHasField]
		public bool HasInt64{
			get { return base.has_field.has_field(4); }
		}
		
		private Int64 _Int64; // tag 4
		public Int64 Int64 {
			get{ return _Int64; }
			set{ base.has_field.set_field(4,true); _Int64 = value; }
		}
		
		[SprotoHasField]
		public bool HasUint64{
			get { return base.has_field.has_field(5); }
		}
		
		private UInt64 _Uint64; // tag 5
		public UInt64 Uint64 {
			get{ return _Uint64; }
			set{ base.has_field.set_field(5,true); _Uint64 = value; }
		}
		
		[SprotoHasField]
		public bool HasBool{
			get { return base.has_field.has_field(6); }
		}
		
		private bool _Bool; // tag 6
		public bool Bool {
			get{ return _Bool; }
			set{ base.has_field.set_field(6,true); _Bool = value; }
		}
		
		[SprotoHasField]
		public bool HasFloat32{
			get { return base.has_field.has_field(7); }
		}
		
		private float _Float32; // tag 7
		public float Float32 {
			get{ return _Float32; }
			set{ base.has_field.set_field(7,true); _Float32 = value; }
		}
		
		[SprotoHasField]
		public bool HasFloat64{
			get { return base.has_field.has_field(8); }
		}
		
		private double _Float64; // tag 8
		public double Float64 {
			get{ return _Float64; }
			set{ base.has_field.set_field(8,true); _Float64 = value; }
		}
		
		[SprotoHasField]
		public bool HasStream{
			get { return base.has_field.has_field(9); }
		}
		
		private byte[] _Stream; // tag 9
		public byte[] Stream {
			get{ return _Stream; }
			set{ base.has_field.set_field(9,true); _Stream = value; }
		}
		
		
		public MyData() : base(max_field_count) {}
		
		public MyData(byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}
		
		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				
				case 0:
					this.name = base.deserialize.read_string();
					break;
				
				case 1:
					this.Type = base.deserialize.read_enum<MyCar>();
					break;
				
				case 2:
					this.Int32 = base.deserialize.read_int32();
					break;
				
				case 3:
					this.Uint32 = base.deserialize.read_uint32();
					break;
				
				case 4:
					this.Int64 = base.deserialize.read_int64();
					break;
				
				case 5:
					this.Uint64 = base.deserialize.read_uint64();
					break;
				
				case 6:
					this.Bool = base.deserialize.read_boolean();
					break;
				
				case 7:
					this.Float32 = base.deserialize.read_float32();
					break;
				
				case 8:
					this.Float64 = base.deserialize.read_double();
					break;
				
				case 9:
					this.Stream = base.deserialize.read_bytes();
					break;
				
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}
		
		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			
			if (base.has_field.has_field (0)) {
				base.serialize.write_string(this.name, 0);
			}
			
			if (base.has_field.has_field (1)) {
				base.serialize.write_enum(this.Type, 1);
			}
			
			if (base.has_field.has_field (2)) {
				base.serialize.write_int32(this.Int32, 2);
			}
			
			if (base.has_field.has_field (3)) {
				base.serialize.write_uint32(this.Uint32, 3);
			}
			
			if (base.has_field.has_field (4)) {
				base.serialize.write_int64(this.Int64, 4);
			}
			
			if (base.has_field.has_field (5)) {
				base.serialize.write_uint64(this.Uint64, 5);
			}
			
			if (base.has_field.has_field (6)) {
				base.serialize.write_boolean(this.Bool, 6);
			}
			
			if (base.has_field.has_field (7)) {
				base.serialize.write_float32(this.Float32, 7);
			}
			
			if (base.has_field.has_field (8)) {
				base.serialize.write_double(this.Float64, 8);
			}
			
			if (base.has_field.has_field (9)) {
				base.serialize.write_bytes(this.Stream, 9);
			}
			

			return base.serialize.close ();
		}
	}

	
	public class MyProfile : SprotoTypeBase {
		private static int max_field_count = 3;
		
		
		[SprotoHasField]
		public bool HasNameField{
			get { return base.has_field.has_field(0); }
		}
		
		private MyData _nameField; // tag 0
		public MyData nameField {
			get{ return _nameField; }
			set{ base.has_field.set_field(0,true); _nameField = value; }
		}
		
		[SprotoHasField]
		public bool HasNameArray{
			get { return base.has_field.has_field(1); }
		}
		
		private List<MyData> _nameArray; // tag 1
		public List<MyData> nameArray {
			get{ return _nameArray; }
			set{ base.has_field.set_field(1,true); _nameArray = value; }
		}
		
		[SprotoHasField]
		public bool HasNameMap{
			get { return base.has_field.has_field(2); }
		}
		
		private Dictionary<MyCar,MyData> _nameMap; // tag 2
		public Dictionary<MyCar,MyData> nameMap {
			get{ return _nameMap; }
			set{ base.has_field.set_field(2,true); _nameMap = value; }
		}
		
		
		public MyProfile() : base(max_field_count) {}
		
		public MyProfile(byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}
		
		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				
				case 0:
					this.nameField = base.deserialize.read_obj<MyData>();
					break;
				
				case 1:
					this.nameArray = base.deserialize.read_obj_list<MyData>();
					break;
				
				case 2:
					this.nameMap = base.deserialize.read_map<MyCar,MyData>(v => v.Type);
					break;
				
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}
		
		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			
			if (base.has_field.has_field (0)) {
				base.serialize.write_obj(this.nameField, 0);
			}
			
			if (base.has_field.has_field (1)) {
				base.serialize.write_obj(this.nameArray, 1);
			}
			
			if (base.has_field.has_field (2)) {
				base.serialize.write_obj(this.nameMap, 2);
			}
			

			return base.serialize.close ();
		}
	}

	
	public class Person : SprotoTypeBase {
		private static int max_field_count = 4;
		
		
		[SprotoHasField]
		public bool HasName{
			get { return base.has_field.has_field(0); }
		}
		
		private string _name; // tag 0
		public string name {
			get{ return _name; }
			set{ base.has_field.set_field(0,true); _name = value; }
		}
		
		[SprotoHasField]
		public bool HasId{
			get { return base.has_field.has_field(1); }
		}
		
		private Int32 _id; // tag 1
		public Int32 id {
			get{ return _id; }
			set{ base.has_field.set_field(1,true); _id = value; }
		}
		
		[SprotoHasField]
		public bool HasEmail{
			get { return base.has_field.has_field(2); }
		}
		
		private string _email; // tag 2
		public string email {
			get{ return _email; }
			set{ base.has_field.set_field(2,true); _email = value; }
		}
		
		[SprotoHasField]
		public bool HasPhone{
			get { return base.has_field.has_field(3); }
		}
		
		private List<PhoneNumber> _phone; // tag 3
		public List<PhoneNumber> phone {
			get{ return _phone; }
			set{ base.has_field.set_field(3,true); _phone = value; }
		}
		
		
		public Person() : base(max_field_count) {}
		
		public Person(byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}
		
		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				
				case 0:
					this.name = base.deserialize.read_string();
					break;
				
				case 1:
					this.id = base.deserialize.read_int32();
					break;
				
				case 2:
					this.email = base.deserialize.read_string();
					break;
				
				case 3:
					this.phone = base.deserialize.read_obj_list<PhoneNumber>();
					break;
				
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}
		
		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			
			if (base.has_field.has_field (0)) {
				base.serialize.write_string(this.name, 0);
			}
			
			if (base.has_field.has_field (1)) {
				base.serialize.write_int32(this.id, 1);
			}
			
			if (base.has_field.has_field (2)) {
				base.serialize.write_string(this.email, 2);
			}
			
			if (base.has_field.has_field (3)) {
				base.serialize.write_obj(this.phone, 3);
			}
			

			return base.serialize.close ();
		}
	}

	
	public class PhoneNumber : SprotoTypeBase {
		private static int max_field_count = 2;
		
		
		[SprotoHasField]
		public bool HasNumber{
			get { return base.has_field.has_field(0); }
		}
		
		private string _number; // tag 0
		public string number {
			get{ return _number; }
			set{ base.has_field.set_field(0,true); _number = value; }
		}
		
		[SprotoHasField]
		public bool HasType{
			get { return base.has_field.has_field(1); }
		}
		
		private Int32 _type; // tag 1
		public Int32 type {
			get{ return _type; }
			set{ base.has_field.set_field(1,true); _type = value; }
		}
		
		
		public PhoneNumber() : base(max_field_count) {}
		
		public PhoneNumber(byte[] buffer) : base(max_field_count, buffer) {
			this.decode ();
		}
		
		protected override void decode () {
			int tag = -1;
			while (-1 != (tag = base.deserialize.read_tag ())) {
				switch (tag) {
				
				case 0:
					this.number = base.deserialize.read_string();
					break;
				
				case 1:
					this.type = base.deserialize.read_int32();
					break;
				
				default:
					base.deserialize.read_unknow_data ();
					break;
				}
			}
		}
		
		public override int encode (SprotoStream stream) {
			base.serialize.open (stream);

			
			if (base.has_field.has_field (0)) {
				base.serialize.write_string(this.number, 0);
			}
			
			if (base.has_field.has_field (1)) {
				base.serialize.write_int32(this.type, 1);
			}
			

			return base.serialize.close ();
		}
	}


    public class RegisterEntry
    {
        static readonly Type[] _types = new Type[]{ 
                typeof(AddressBook), // 2618161298
                typeof(MyData), // 2244887298
                typeof(MyProfile), // 438153711
                typeof(Person), // 1498745430
                typeof(PhoneNumber), // 4271979557
            };

        public static Type[] GetClassTypes()
        {
            return _types;
        }
    }
}
