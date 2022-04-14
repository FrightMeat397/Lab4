using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ast.Statements {
	sealed class Break:IStatement {
			public readonly int LoopCount;
			public string FormattedString => $"break {LoopCount};";
			public Break(int number) {
			LoopCount = number;
			}
			public void Accept(IStatementVisitor visitor) => visitor.VisitBreak(this);
			public T Accept<T>(IStatementVisitor<T> visitor) => visitor.VisitBreak(this);
	}
}
