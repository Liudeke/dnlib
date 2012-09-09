﻿namespace dot10.dotNET {
	/// <summary>
	/// Event attributes, see CorHdr.h/CorEventAttr
	/// </summary>
	public enum EventAttributes : ushort {
		/// <summary>event is special.  Name describes how.</summary>
		SpecialName			= 0x0200,
		/// <summary>Runtime(metadata internal APIs) should check name encoding.</summary>
		RTSpecialName		= 0x0400,
	}
}
