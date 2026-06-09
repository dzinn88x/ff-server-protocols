using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CF6 RID: 7414
	[Token(Token = "0x2001CF6")]
	internal struct PetConfigInfo
	{
		// Token: 0x0600A1A7 RID: 41383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1A7")]
		[Address(RVA = "0x11F11E0", Offset = "0x11F11E0", VA = "0x7BBB9F11E0")]
		public PetConfigInfo(uint pet_id, uint Lv)
		{
		}

		// Token: 0x0400A80F RID: 43023
		[Token(Token = "0x400A80F")]
		[FieldOffset(Offset = "0x0")]
		public uint Pet_ID;

		// Token: 0x0400A810 RID: 43024
		[Token(Token = "0x400A810")]
		[FieldOffset(Offset = "0x4")]
		public int Exp;

		// Token: 0x0400A811 RID: 43025
		[Token(Token = "0x400A811")]
		[FieldOffset(Offset = "0x8")]
		public int RareType;

		// Token: 0x0400A812 RID: 43026
		[Token(Token = "0x400A812")]
		[FieldOffset(Offset = "0xC")]
		public uint Level;

		// Token: 0x0400A813 RID: 43027
		[Token(Token = "0x400A813")]
		[FieldOffset(Offset = "0x10")]
		public PetData Pet_Data;

		// Token: 0x0400A814 RID: 43028
		[Token(Token = "0x400A814")]
		[FieldOffset(Offset = "0x18")]
		public List<PetActionData> PetAction_data_List;

		// Token: 0x0400A815 RID: 43029
		[Token(Token = "0x400A815")]
		[FieldOffset(Offset = "0x20")]
		public List<PetSkinData> PetSkin_Data_List;

		// Token: 0x0400A816 RID: 43030
		[Token(Token = "0x400A816")]
		[FieldOffset(Offset = "0x28")]
		public List<PetSkillInfoData> PetSkill_Data_list;

		// Token: 0x0400A817 RID: 43031
		[Token(Token = "0x400A817")]
		[FieldOffset(Offset = "0x30")]
		public PetLevelExpData Pet_Exp_Data;
	}
}
